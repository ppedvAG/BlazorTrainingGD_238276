namespace BlazorTrainingGD_238276.Pages.modul4
{
    public class ChatVM
    {
       public Action OnAdd;
        public List<Nachricht> Liste { get; set; }=new List<Nachricht>();

        public void Add(string msg)
        {
            Liste.Add(new Nachricht() { Text = msg });
            OnAdd?.Invoke();
        }
    }
}
