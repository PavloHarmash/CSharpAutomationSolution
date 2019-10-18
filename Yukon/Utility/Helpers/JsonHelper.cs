using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Yukon.Utility.Helpers
{
    class JsonHelper
    {
        /// <summary>
        /// Serializes object into JSON string without null values
        /// </summary>
        /// <typeparam name="T">Type that will be serialized</typeparam>
        /// <param name="objectToSerialize">Object to serialize</param>
        /// <returns></returns>
        public static string SerializeHandlingNullValues<T>(T objectToSerialize)
        {
            return JsonConvert.SerializeObject(
                objectToSerialize,
                Formatting.None,
                new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }
                );
        }

        /// <summary>
        /// Parses JSON file into given type
        /// Requires JSON file location in current solution
        /// </summary>
        /// <typeparam name="T">Type to be deserialized into</typeparam>
        /// <param name="jsonFileLocation">
        /// JSON file location starting from base directory
        /// e.g. Utility/Configs/some.json</param>
        /// <returns></returns>
        public static T DeserializeJson<T>(string jsonFileLocation)
        {
            string pathToJson = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, jsonFileLocation);
            string jsonContent;

            if (File.Exists(pathToJson))
            {
                jsonContent = File.ReadAllText(pathToJson);
                return JsonConvert.DeserializeObject<T>(jsonContent);
            }

            return default;
        }
    }
}