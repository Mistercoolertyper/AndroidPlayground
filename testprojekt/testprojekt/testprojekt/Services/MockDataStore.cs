using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testprojekt.Models;
using Xamarin.Essentials;

namespace testprojekt.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        readonly List<Item> items = new List<Item>();

        public MockDataStore()
        {
          
         
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var oldItem = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            var locales = await TextToSpeech.GetLocalesAsync();
            items.Clear();
            items.AddRange(locales.Select(i => new Item
            {
                Id = Guid.NewGuid().ToString(),
                Text = i.Name,
                Description = i.Language,
            }));

            return await Task.FromResult(items);
        }
    }
}