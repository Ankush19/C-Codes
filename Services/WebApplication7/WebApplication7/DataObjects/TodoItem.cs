using Microsoft.WindowsAzure.Mobile.Service;

namespace WebApplication7.DataObjects
{
    public class TodoItem : EntityData
    {
        public string Text { get; set; }

        public bool Complete { get; set; }
    }
}