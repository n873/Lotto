namespace Lotto.Domain.Model
{
    /// <summary>
    /// ILotto defines what will always be expected from an instance of a Lotto type
    /// </summary>
    public interface ILotto
    {
        void CaptureDraw(params int[] draw);
        string GetDivision(params int[] draw);
    }
}