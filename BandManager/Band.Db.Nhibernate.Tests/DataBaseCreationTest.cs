using System;
using Band.Domain;
using NUnit.Framework;

namespace Band.Db.Nhibernate.Tests
{
    [TestFixture]
    public class DataBaseCreationTest
    {
        [Test]
        public void CreateDatabaseTest()
        {
            DataBase.CreateDatabase();
        }

        [Test]
        public void PutSomeDataTest()
        {
            var sessionFactory = DataBase.CreateSessionFactory();
            using (var session = sessionFactory.OpenSession())
            {
                var songTypeRepository = new NHibernateRepository<SongType, int>(session);
                var rockSongType = new SongType()
                {
                    Name = "Rock"
                };

                var popSongType = new SongType()
                {
                    Name = "Pop"
                };

                songTypeRepository.Create(rockSongType);
                songTypeRepository.Create(popSongType);

                var songRepository = new NHibernateRepository<Song, string>(session);
                songRepository.Create(new Song()
                {
                    Title = "Last Christmas",
                    Type = popSongType,
                    Chords = "G D C a G",
                    Scale = "G"
                });

                songRepository.Create(new Song()
                {
                    Title = "You're simply the best",
                    Type = rockSongType,
                    Chords = "F B d B F",
                    Scale = "F"
                });

                songRepository.Create(new Song()
                {
                    Title = "Zostańmy razem",
                    Type = rockSongType,
                    Chords = "B Es d B F",
                    Scale = "B"
                });

                songRepository.Create(new Song()
                {
                    Title = "Kocham Cie",
                    Type = rockSongType,
                    Chords = "G D a D C G",
                    Scale = "G"
                });

                var agreement = new Agreement()
                {
                    Name = "Agnieszka Pasternak",
                    Address = "Tomaszów Mazowiecki, ul. Nadpiliczna",
                    Amount = 5000,
                    Signed = true,
                    StartTime = new DateTime(2010, 1, 1),
                    TimeStamp = DateTime.UtcNow,
                    City = "Tomaszów Mazowiecki",
                    DownPayment = 1000,
                    Member = "Grzegorz Pasternak",
                    Phone = "707345555",
                    Place = "Zajazd",
                    Remarks = "Don't be late"
                };

                var agreementRepository = new NHibernateRepository<Agreement, int>(session);
                agreementRepository.Create(agreement);

            session.Flush();
            }
        }
    }
}
