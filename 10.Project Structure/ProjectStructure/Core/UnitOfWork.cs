using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class UnitOfWork
    {
        private ComplexFoodContext _context;
        private BuyerRepository ?_buyerRepository;
        public UnitOfWork(ComplexFoodContext context)
        {
            _context = context;
        }

        public BuyerRepository BuyerRepository
        {
            get
            {
                if(_buyerRepository == null)
                {
                    _buyerRepository = new BuyerRepository(_context);
                }   
                return _buyerRepository;
            }
        }
    }
}
