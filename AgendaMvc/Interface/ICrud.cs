namespace AgendaMvc.Interface
{
    public interface ICrud<T>
    {
       public bool salvar(T t);
        bool alterar(T t);
       public T consultar(int id);
        List<T> consultar();
        void excluir(int id);
    }
}
