using System.Collections.Generic;

namespace dotflix {
    public interface IRepositorio<T> {
        List<T> Lista();

        T ReturnById(int id);

        void Insert(T entidade);

        void Delete(int id);

        void Update(int id, T entidade);

        int NextId();
    }
}