using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace App.Data
{
    public class WeaponJsonConverter
    {
        public class SoundSkinCustomListConverter : JsonConverter<List<SoundSkinCustom>>
        {
            public override List<SoundSkinCustom> ReadJson(JsonReader reader, System.Type objectType, List<SoundSkinCustom> existingValue, bool hasExistingValue, JsonSerializer serializer)
            {
                JArray outerArray = JArray.Load(reader);
                var list = new List<SoundSkinCustom>();
                foreach (JArray innerArray in outerArray)
                {
                    if (innerArray.Count < 4)
                        throw new JsonSerializationException("Expected array of at least 4 elements");
                    list.Add(new SoundSkinCustom
                    {
                        skin = innerArray[0].ToString(),
                        sound = innerArray[1].ToString(),
                        variations = innerArray[2].Value<int>(),
                        mode = innerArray[3].ToString()
                    });
                }
                return list;
            }

            public override void WriteJson(JsonWriter writer, List<SoundSkinCustom> value, JsonSerializer serializer)
            {
                writer.WriteStartArray();
                foreach (var item in value)
                {
                    writer.WriteStartArray();
                    writer.WriteValue(item.skin);
                    writer.WriteValue(item.sound);
                    writer.WriteValue(item.variations);
                    writer.WriteValue(item.mode);
                    writer.WriteEndArray();
                }
                writer.WriteEndArray();
            }
        }

        public class SkinSoundPairListConverter : JsonConverter<List<SkinSoundPair>>
        {
            public override List<SkinSoundPair> ReadJson(JsonReader reader, System.Type objectType, List<SkinSoundPair> existingValue, bool hasExistingValue, JsonSerializer serializer)
            {
                JArray outerArray = JArray.Load(reader);
                var list = new List<SkinSoundPair>();
                foreach (JToken token in outerArray)
                {
                    if (token is JObject obj)
                    {
                        list.Add(obj.ToObject<SkinSoundPair>());
                    }
                    else if (token is JArray innerArray)
                    {
                        if (innerArray.Count < 2)
                            throw new JsonSerializationException("Expected array of at least 2 elements");
                        list.Add(new SkinSoundPair
                        {
                            skin = innerArray[0].ToString(),
                            sound = innerArray[1].ToString()
                        });
                    }
                    else
                    {
                        throw new JsonSerializationException($"Unexpected token type: {token.Type}");
                    }
                }
                return list;
            }

            public override void WriteJson(JsonWriter writer, List<SkinSoundPair> value, JsonSerializer serializer)
            {
                writer.WriteStartArray();
                foreach (var item in value)
                {
                    writer.WriteStartObject();
                    writer.WritePropertyName("skin");
                    writer.WriteValue(item.skin);
                    writer.WritePropertyName("sound");
                    writer.WriteValue(item.sound);
                    writer.WriteEndObject();
                }
                writer.WriteEndArray();
            }
        }

        public class SlotAttachmentListConverter : JsonConverter<List<SlotAttachment>>
        {
            public override List<SlotAttachment> ReadJson(JsonReader reader, System.Type objectType, List<SlotAttachment> existingValue, bool hasExistingValue, JsonSerializer serializer)
            {
                JArray outerArray = JArray.Load(reader);
                var list = new List<SlotAttachment>();
                foreach (JArray innerArray in outerArray)
                {
                    if (innerArray.Count < 3)
                        throw new JsonSerializationException("Expected array of at least 3 elements");
                    list.Add(new SlotAttachment
                    {
                        slot = innerArray[0].ToString(),
                        attachment = innerArray[1].ToString(),
                        region = innerArray[2].ToString()
                    });
                }
                return list;
            }

            public override void WriteJson(JsonWriter writer, List<SlotAttachment> value, JsonSerializer serializer)
            {
                writer.WriteStartArray();
                foreach (var item in value)
                {
                    writer.WriteStartArray();
                    writer.WriteValue(item.slot);
                    writer.WriteValue(item.attachment);
                    writer.WriteValue(item.region);
                    writer.WriteEndArray();
                }
                writer.WriteEndArray();
            }
        }
    }
}
