﻿using Blazored.SessionStorage;
using System.Text;
using System.Text.Json;

namespace BlazorAspNetCoreHostedDemo.Client.Extensions
{
    public static class SessionStorageServiceExtensions
    {
        public static async Task SaveItemEncryptedAsync<T>(this ISessionStorageService sessionStorageService, string key, T item)
        {
            var itemJson = JsonSerializer.Serialize(item);
            var itemJsonBytes = Encoding.UTF8.GetBytes(itemJson);
            var based64Json = Convert.ToBase64String(itemJsonBytes);
            await sessionStorageService.SetItemAsync(key, based64Json);
        }

        public static async Task<T> ReadEncryptedItemAsync<T>(this ISessionStorageService sessionStorageService, string key)
        {
            var based64Json = await sessionStorageService.GetItemAsync<string>(key);
            var itemJsonBytes = Convert.FromBase64String(based64Json);
            var itemJson = Encoding.UTF8.GetString(itemJsonBytes);
            var item = JsonSerializer.Deserialize<T>(itemJson);
            return item;
        }
    }
}
