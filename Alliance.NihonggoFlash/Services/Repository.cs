using Alliance.NihonggoFlash.Models;
using SQLite.CodeFirst;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alliance.NihonggoFlash.Services
{
    public interface IRepository
    {
        IDbSet<FlashCard> Cards { get; }
    }

    public sealed class Repository : DbContext, IRepository
    {       

        public IDbSet<FlashCard> Cards { get; private set; }

        public Repository()
            : base("FlashCardsDb")
        {
            Cards = Set<FlashCard>();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var sqliteConnectionInitializer = new FlashCardDbContextInitializer(modelBuilder);
            Database.SetInitializer(sqliteConnectionInitializer);
        }
    }

    public class FlashCardDbContextInitializer : SqliteCreateDatabaseIfNotExists<Repository>
    {
        public FlashCardDbContextInitializer(DbModelBuilder modelBuilder)
            : base(modelBuilder) { }

        protected override void Seed(Repository context)
        {
            var cards = context.Cards;
            cards.Add(new FlashCard {
                Word = "Blah1",
                HowToRead = "Blah2",
                Meaning = "Blah3",
                Sample = "Blah4"
            });

            cards.Add(new FlashCard
            {
                Word = "Di Na",
                HowToRead = "Jud ko",
                Meaning = "Muusab",
                Sample = "Kausa na LAAANNNGGG"
            });

            cards.Add(new FlashCard
            {
                Word = "aaa",
                HowToRead = "bbb",
                Meaning = "ccccc",
                Sample = "dd"
            });

            context.SaveChanges();
            base.Seed(context);
        }
    }
}
