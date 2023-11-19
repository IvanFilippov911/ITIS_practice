using System.Data.SqlTypes;

namespace TextAnalysis;
static class FrequencyAnalysisTask
{
    public static Dictionary<string, string> GetMostFrequentNextWords(List<List<string>> text)
    {
        var result = new Dictionary<string, string>();
        var DictCountValuesBigram = FrequencyAnalysisTask.CreateDictCountValues(text, "bigram");
        var DictCountValuesTrigram = FrequencyAnalysisTask.CreateDictCountValues(text, "trigram");
        var DictCountValues = DictCountValuesBigram.Union(DictCountValuesTrigram).ToDictionary(x => x.Key, x => x.Value);
        
        foreach (var entry in DictCountValues)
        {
            var key = entry.Key;
            var value = entry.Value;
            var listKey = key.Split(" ");
            var keyForResult = "";
            var valueForResult = "";

            if (listKey.Length == 2)
            {
                keyForResult = listKey[0];
                valueForResult = listKey[1];
            }
            else if (listKey.Length == 3)
            {
                keyForResult = $"{listKey[0]} {listKey[1]}";
                valueForResult = listKey[2];

            }
            
            if (!result.ContainsKey(keyForResult))
            {
                result[keyForResult] = valueForResult;
            }
            
            
            else if (value > DictCountValues[keyForResult + " " + result[keyForResult]])
                result[keyForResult] = valueForResult;
            
            
            else if (value == DictCountValues[keyForResult + " " + result[keyForResult]]);
            {
                if (String.CompareOrdinal(result[keyForResult], valueForResult) > 0)
                    result[keyForResult] = valueForResult;
            }
            
        }
        return result;
    }

    private static Dictionary<string, int> CreateDictCountValues(List<List<string>> text, string typeKeys)
    {
        var result = new Dictionary<string, int>();
        var endSecondCycle = typeKeys.Length - 5;

        for (int i = 0; i < text.Count; i++)
        {
            for (int j = 0; j < text[i].Count - endSecondCycle; j++)
            {
                string key;
                if (typeKeys == "bigram")
                {
                    key = $"{text[i][j]} {text[i][j + 1]}";
                    if (!result.ContainsKey(key))
                        result[key] = FrequencyAnalysisTask.ReturnCountSubstring(key, text, typeKeys);
                }
                else if (typeKeys == "trigram")
                {
                    key = $"{text[i][j]} {text[i][j + 1]} {text[i][j + 2]}";
                    if (!result.ContainsKey(key))
                        result[key] = FrequencyAnalysisTask.ReturnCountSubstring(key, text, typeKeys);
                }
            }
        }
        return result;
    }
    private static int ReturnCountSubstring(string substring, List<List<string>> text, string typeKeys)
    {
        var count = 0;
        var endSecondCycle = typeKeys.Length - 5;

        if (typeKeys == "bigram")
        {
            for (int i = 0; i < text.Count; i++)
            {
                for (int j = 0; j < text[i].Count - endSecondCycle; j++)
                {
                    if ($"{text[i][j]} {text[i][j + 1]}" == substring) count++;
                }
            }
        }
        else if (typeKeys == "trigram")
        {
            for (int i = 0; i < text.Count; i++)
            {
                for (int j = 0; j < text[i].Count - endSecondCycle; j++)
                {
                    if ($"{text[i][j]} {text[i][j + 1]}" == substring) count++;
                }
            }

        }
        return count;
    }

}
