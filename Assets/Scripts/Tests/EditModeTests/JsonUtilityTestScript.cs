using NUnit.Framework;
using UnityEngine;

namespace Tests
{
    public class JsonUtilityTestScript
    {
        [Test]
        public void JsonUtilityToJsonPasses()
        {
            Vector2 vector2 = new(4, 2);
            string json = JsonUtility.ToJson(vector2);
            Assert.AreEqual("{\"x\":4.0,\"y\":2.0}", json);
        }

        [Test]
        public void JsonUtilityFromJsonPasses()
        {
            Vector2 fromJson = JsonUtility.FromJson<Vector2>("{\"x\":4.0,\"y\":2.0}");
            Vector2 vector2 = new(4, 2);
            Assert.AreEqual(vector2, fromJson);
        }
    }
}