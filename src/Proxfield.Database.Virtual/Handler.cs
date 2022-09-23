using System;
using System.Collections.Generic;
using System.Linq;

namespace Proxfield.Database.Virtual
{
    public class Handler
    {
        private readonly string _name;
        private readonly List<BaseEntity> _entities;
        private readonly Type _type;

        public Handler(string name, Type type)
        {
            _name = name;
            _type = type;
            _entities = new List<BaseEntity>();
        }

        public BaseEntity Get(int index) => _entities[index];

        public BaseEntity Get(string id) => _entities.Where(x => x.Id?.Equals(id) ?? false)
            .FirstOrDefault();

        public List<BaseEntity> GetEntities() => _entities;

        public void Set(BaseEntity entity) => _entities.Add(entity);

        public void Delete(string id) => _entities
            .Remove(
                _entities.Where(x => x.Id == id).FirstOrDefault()
            );

        public Type EntityType => _type;
    }
}
