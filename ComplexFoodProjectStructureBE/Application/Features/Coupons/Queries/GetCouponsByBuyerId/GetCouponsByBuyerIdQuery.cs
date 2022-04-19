﻿using MediatR;
using Application.DtoModels.Coupon;

namespace Application.Features.Coupons.Queries.GetCouponsByBuyerId
{
    public class GetCouponsByBuyerIdQuery : IRequest<List<CouponDto>>
    {
        public int BuyerId { get; set; }
        public CouponDto Coupon { get; set; }
    }
}
