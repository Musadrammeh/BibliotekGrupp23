using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using Modellager;

namespace Datalager
{
    public class UnitOfWork : IUnitOfWork
    {
        public Repository<Medlem> MedlemRepository { get; private set; }
        public Repository<Bokning> BokningRepository { get; private set; }
        public Repository<Böcker> BöckerRepository { get; private set; }
        public Repository<Faktura> FakturaRepository { get; private set; }
        public Repository<Expidit> ExpiditRepository { get; private set; }

        public UnitOfWork()
        {
            MedlemRepository = new Repository<Medlem>(_context);
            BokningRepository = new Repository<Bokning>(_context);
            BöckerRepository = new Repository<Böcker>(_context);
            FakturaRepository = new Repository<Faktura>(_context);
            Expiditpository = new Repository<Expidit>(_context);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
          

    }
}
