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
        public Repository<Bok> BokRepository { get; private set; }
        public Repository<Faktura> FakturaRepository { get; private set; }
        public Repository<Expedit> ExpeditRepository { get; private set; }

        public UnitOfWork()
        {
            MedlemRepository = new Repository<Medlem>(_context);
            BokningRepository = new Repository<Bokning>(_context);
            BokRepository = new Repository<Bok>(_context);
            FakturaRepository = new Repository<Faktura>(_context);
            Expeditpository = new Repository<Expedit>(_context);
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
