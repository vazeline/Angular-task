using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Entity;

namespace WebAPI.Services
{
    public class BackeryService : IBackeryService
    {
        static List<IBackery> _allItems = new List<IBackery>();

        private Backery _backery = new Backery();

        public async Task<IEnumerable<IBackery>> CreateItems(int count)
        {
            _allItems.Clear();
            for(int i = 0; i < count; i++)
            {
                _allItems.Add(_backery.NewItem());
            }
            //long running request
            return await Task.FromResult(_allItems);
        }

        public async Task<IEnumerable<IBackery>> GetAllItems()
        {
            var currentItems = _allItems.ToArray();

            foreach(var item in currentItems)
            {
                if (item.ShouldBeDisposed)
                    _allItems.Remove(item);
            }
            //long running request
            return await Task.FromResult(_allItems);
        }
    }
}
