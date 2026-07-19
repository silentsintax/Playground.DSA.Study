namespace Entrypoint.Arrays._01_CustomList
{
    public class CustomizedList<T>
    {
        private T[] _items; //array interno para guardar os elementos.
        private int _count; //quantidade de elementos armazenados.

        public CustomizedList(int initialCapacity = 4) 
        {
            _items = new T[initialCapacity];
            _count = 0;
        }
        public int Count => _count;

        private void Grow() 
        {
            int newCapacity = _items.Length * 2; //Sempre o dobro da lista original
            T[] newArray = new T[newCapacity];

            for(int i = 0; i < _count; i++)
                newArray[i] = _items[i]; //efetua a copia dos dados do antigo array para o novo array

            _items = newArray; // efetua a troca do array antigo pelo novo array
        }

        public void Add(T item) 
        {
            if (_count == _items.Length) // se o array estiver cheio, chama o método Grow para aumentar a capacidade do array
                this.Grow();

            _items[_count] = item;
            _count++;
        }

        public T Get(int index) 
        {
            if(index < 0 || index >= _count) //se o index for menor que 0 ou maior que a quantidade de elementos armazenados, lança uma exceção
                throw new IndexOutOfRangeException("Index is out of range.");

            return _items[index];
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= _count)//se o index for menor que 0 ou maior que a quantidade de elementos armazenados, lança uma exceção
                throw new IndexOutOfRangeException("Index is out of range.");

            for (int i = index; i < _count - 1; i++)
                _items[i] = _items[i + 1]; //joga os itens subsequentes para a esquerda

            _count--;
        }
    }
}
