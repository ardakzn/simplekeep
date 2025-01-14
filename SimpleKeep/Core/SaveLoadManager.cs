// Copyright Arda Kozan, All Rights Reserved 2025.

using System;
using System.IO;
using System.Threading.Tasks;
using UnityEngine;
using Debug = UnityEngine.Debug;

namespace SimpleKeep.Core
{
    public static class SaveLoadManager<T> where T : class, new()
    {
        // Save Method
        public static void Save(string filePath, T data)
        {
            try
            {
                string jsonData = JsonUtility.ToJson(data); // Convert object to JSON format
                File.WriteAllText(filePath, jsonData);// Write JSON data to file
                Debug.Log("[SimpleKeep] Data saved to " + filePath);
            }
            catch (Exception e)
            {
                Debug.LogError("[SimpleKeep] Failed to save data: " + e.Message);
            }
        }

        // Load Method
        public static T Load(string filePath)
        {
            if (!File.Exists(filePath))
            {
                Debug.LogWarning("[SimpleKeep] No data found, starting fresh.");
                return new T(); // If the file does not exist, return a default object
            }

            string jsonData = File.ReadAllText(filePath); // Read JSON data from file
            Debug.Log("[SimpleKeep] Data Loaded");
            return JsonUtility.FromJson<T>(jsonData); // Convert JSON to object
        }

        // Asynchronous Save Method
        public static async Task SaveAsync(string filePath, T data)
        {
            string jsonData = JsonUtility.ToJson(data);
            await WriteToFileAsync(filePath, jsonData);
            Debug.Log("[SimpleKeep] Data saved to " + filePath);
        }

        // Make writing to file asynchronous
        private static async Task WriteToFileAsync(string filePath, string data)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                await writer.WriteAsync(data);
            }
        }

        // Asynchronous Load Method
        public static async Task<T> LoadAsync(string filePath)
        {
            if (!File.Exists(filePath))
            {
                Debug.LogWarning("[SimpleKeep] No data found, starting fresh.");
                return new T(); 
            }

            string jsonData = await ReadFromFileAsync(filePath);
            Debug.Log("[SimpleKeep] Data Loaded");
            return JsonUtility.FromJson<T>(jsonData);
        }

        // Read data from file asynchronously
        private static async Task<string> ReadFromFileAsync(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                return await reader.ReadToEndAsync();
            }
        }
    }
}