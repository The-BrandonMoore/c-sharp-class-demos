using CH20EFBmdbConsole.Models;

namespace CH20EFBmdbConsole.Db
{
    internal class ActorDb
    {
        private BmdbContext dbContextActor = new();
        public List<Actor> GetActors()
        {
            return dbContextActor.Actors.ToList();
        }
        public Actor FindActor(int id)
        {
            return dbContextActor.Actors.Where(a => a.Id == id).FirstOrDefault();
        }
        public void AddActor(Actor actor)
        {
            dbContextActor.Actors.Add(actor);
            dbContextActor.SaveChanges();
        }
        public void UpdateActor(Actor actor) {
            dbContextActor.SaveChanges(true);
        }
        public void RemoveActor(Actor actor)
        {
            dbContextActor.Actors.Remove(actor);
            dbContextActor.SaveChanges();
        }













    }
}
