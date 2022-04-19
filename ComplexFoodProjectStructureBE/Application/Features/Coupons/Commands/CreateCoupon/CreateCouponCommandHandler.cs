using Application.Contracts.Persistence;
using MediatR;
using Domain.Models.Shopping;
using AutoMapper;
using Domain.Models.Enums;
using Domain.ValueObjects;

namespace Application.Features.Coupons.Commands.CreateCoupon
{
    public class CreateCouponCommandHandler : IRequestHandler<CreateCouponCommand, string>
    {

        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        
        public CreateCouponCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<string> Handle(CreateCouponCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var buyer = await _unitOfWork.Buyers.GetByIdAsync(request.BuyerId);
                if (buyer != null)
                {
                    if (buyer.Balance.Value > 0)
                    {
                        var totalPrice = 0;
                        switch (request.Coupon.Type)
                        {
                            case TypeCoupons.TenProcent:
                                totalPrice = request.Amount.Value * 10; 
                                break;
                            case TypeCoupons.TwentyProcent:
                                totalPrice = request.Amount.Value * 15;
                                break;
                            case TypeCoupons.ThirtyProcent:
                                totalPrice = request.Amount.Value * 20;
                                break;
                        }

                        if (buyer.Balance.Value >= totalPrice)
                        {
                            for (var i = 0; i < request.Amount.Value; i++)
                            {
                                request.Coupon.Code = new UniqueCode(RandomCode(6));
                                request.Coupon.BuyerId = buyer.Id;
                                var coupon = _mapper.Map<Coupon>(request.Coupon);
                                await _unitOfWork.Coupons.AddAsync(coupon);
                            }

                            buyer.Balance = new Balance(buyer.Balance.Value - totalPrice);                               
                            await _unitOfWork.CommitAsync(cancellationToken);
                        }
                        else
                        {
                            return "Fonduri insuficiente..";
                        }
                      
                    }
                  
                }
                else
                {
                    return $"Utilizatorul nu a fost gasit!";
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "Nu s-a achizionat cuponuri!";
            }
            
            return $"Achizionarea Cupoanelor {request.Coupon.Type} de reducere a fost cu succes!";
        }

        private static string RandomCode(int length)
        {
            var ran = new Random();

            var b = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            string random = "";

            for (var i = 0; i < length; i++)
            {
                var a = ran.Next(b.Length);
                random = random + b.ElementAt(a);
            }

            return random;
        }
    }  

}
