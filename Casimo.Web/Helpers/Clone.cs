using Newtonsoft.Json;

namespace Casimo.Web.Helpers;

/// <summary>
/// Utility class for deep cloning objects using JSON serialization
/// Provides a simple way to create independent copies of complex objects
/// </summary>
public static class Clone
{
    /// <summary>
    /// Creates a deep clone of the specified object using JSON serialization
    /// </summary>
    /// <typeparam name="T">The type of object to clone</typeparam>
    /// <param name="source">The source object to clone</param>
    /// <returns>A new instance of the object with identical values</returns>
    /// <exception cref="Exception">Thrown when deserialization fails</exception>
    public static T CloneObject<T>(T source)
    {
        string ser = JsonConvert.SerializeObject(source);
        T? res = JsonConvert.DeserializeObject<T>(ser);
        return res ?? throw new Exception("Failed to clone object.");
    }
}