namespace MetodosNumericos.MetodosNumericos
{
    public interface IMetodoNumerico
    {
        void CalcularSiguiente();
        decimal Y();
        decimal Yprima();
        decimal Ysegunda();
    }
}
