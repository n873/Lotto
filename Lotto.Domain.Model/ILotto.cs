namespace Lotto.Domain.Model
{
    public interface ILotto
    {
        void CaptureDraw(params int[] draw);
        string GetDivision(params int[] draw);
    }
}