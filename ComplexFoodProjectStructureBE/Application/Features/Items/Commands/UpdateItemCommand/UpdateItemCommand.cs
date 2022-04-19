﻿using MediatR;
using Domain.ValueObjects;

namespace Application.Features.Items.Commands.UpdateItemCommand
{
    public class UpdateItemCommand : IRequest
    {
        public int ItemId { get; set; }
        public Amount Amount { get; set; }
        
        //mai vedem daca actualizam si produsul in sine
        public int ProductId { get; set; }
    }
}
