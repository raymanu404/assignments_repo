using MediatR;
using Application.DtoModels.Admin;

namespace Application.Features.Admins.Commands
{
    public class CreateAdminCommand : IRequest
    {
        public AdminDto Admin { get; set; }
    }
}
