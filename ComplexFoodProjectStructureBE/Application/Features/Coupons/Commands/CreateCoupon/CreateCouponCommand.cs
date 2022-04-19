using MediatR;
using Application.DtoModels.Coupon;
using Domain.ValueObjects;

namespace Application.Features.Coupons.Commands.CreateCoupon
{
    public class CreateCouponCommand : IRequest<string> 
    { 

        public int BuyerId { get; set; }
        public CouponDto Coupon { get; set; }
        public Amount Amount { get; set; }
    }
}
