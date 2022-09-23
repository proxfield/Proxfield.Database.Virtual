using System.Collections.Generic;
using System.Linq;

namespace Proxfield.Database.Virtual
{
    public class DocumentStore
    {
        private readonly List<Handler> _relations;

        public DocumentStore()
        {
            _relations = new List<Handler>();
        }

        public void AddItem<T>(T entity) where T : BaseEntity
            => _relations
                .Where(x => x.EntityType == typeof(T))
                .First()
                .Set(entity);
    }
}
