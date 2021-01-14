git remote add origin https://github.com/GiovanniDCarvalhoGrech/Pr-tica-de-C-.git
git branch -M main
git push -u origin main

namespace GiovanniDCarvalhoGrech
{
    public class GenericComparerFactory<TEntity> : IEqualityComparer</TEntity>
    {
        private Func<TEntity, object> Predicate { get; set; }

        private GenericComparerFactory() { }

        public static GenericComparerFactory<TEntity> Create(Func<TEntity, object> predicate)
        {
            return new GenericComparerFactory<TEntity>() { Predicate = predicate};
        }
    
    public bool Equals([AllowNull] TEntity x, [AllowNull] TEntity y)
    {
        return Predicate(x).Equals(Predicate(y));
    }

    public int GetHashCode([DisallowNull] TEntity obj)
    {
        return Predicate(obj).GetHashCode();
    }
    }
}