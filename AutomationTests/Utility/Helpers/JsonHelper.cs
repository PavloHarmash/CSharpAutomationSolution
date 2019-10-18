﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTests.Utility.Helpers
{
    class JsonHelper
    {
        /// <summary>
        /// Serializes object into JSON string without null values
        /// </summary>
        /// <typeparam name="T">Type that will be serialized</typeparam>
        /// <param name="obj">Object to serialize</param>
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
        /// Requires JSON file location in current current project starting from folder
        /// e.g. Utility/Configs/some.json
        /// </summary>
        /// <typeparam name="T">Type to be deserialized into</typeparam>
        /// <param name="jsonFileLocation">JSON file location</param>
        /// <returns></returns>
        public static T DeserializeJson<T>(string jsonFileLocation)
        {
            try
            {
                return JsonConvert.DeserializeObject<T>(
                    File.ReadAllText(Path.Combine(
                        Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ??
                        throw new InvalidOperationException(),
                        jsonFileLocation)));
            }
            catch (Exception ex)
            {
                //LogUtil.WriteDebug(ex.GetType().Name + ": " + ex.Message + ": " + ex.StackTrace);
                throw;
            }
        }

        /// <summary>
        /// Tries to parse JSON string into given type
        /// Returns null in case there was a deserialization exception
        /// </summary>
        /// <typeparam name="T">Type to be deserialized into</typeparam>
        /// <param name="json">JSON string</param>
        /// <param name="result">Resulting out parameter of parsed JSON</param>
        /// <returns>Bool value whether or not JSON can be parsed</returns>
        public static bool TryParseJson<T>(string json, out T result)
        {
            result = default(T);
            try
            {
                result = JsonConvert.DeserializeObject<T>(json);
                return true;
            }
            catch (JsonSerializationException)
            {
                LogUtil.WriteDebug($"{json} cannot be deserialized with {nameof(T)}");
                return false;
            }
            catch (Exception ex)
            {
                LogUtil.WriteDebug($"{json} cannot be deserialized with {nameof(T)}, because of exception => {ex.Message}");
                return false;
            }
        }
    }
}
