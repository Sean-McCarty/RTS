using System.Text;
using System.Text.Json;

namespace EmploymentScreening
{
    public class Utilities
    {
        /// <summary>
        /// Counts how many integers are above (greater than) or below (less than) the reference value.<br/><br/>
        /// NOTE: Requirement was to name it aboveBelow, but that violates C# naming conventions.
        /// </summary>
        /// <param name="candidates"></param>
        /// <param name="reference"></param>
        /// <returns>Always returns a valid Dictionary of counts</returns>
        public static string AboveBelow(List<int> candidates, int reference)
        {
            Dictionary<string, int> comparator = new Dictionary<string, int>();
            int above = 0;
            int below = 0;

            if (candidates != null)
                foreach (int candidate in candidates)
                {
                    // if(comparison == reference)...not defined in requirements.
                    if (candidate > reference) above++;
                    if (candidate < reference) below++;
                }

            comparator.Add("above", above);
            comparator.Add("below", below);

            return JsonSerializer.Serialize(comparator, new JsonSerializerOptions());
        }

        /// <summary>
        /// Extracts a string segment from the end and moves it to the beginning <br/>
        /// effectively rotating all characters to the right by the offset amount.<br/><br/>
        /// Offset must be greater than 0 and less than the original string length,<br/>
        /// otherwise the method will simply return the original string.<br/><br/>
        /// NOTE: Requirement was to name it stringRotation, but that violates C# naming conventions.
        /// </summary>
        /// <param name="originalString"></param>
        /// <param name="offset"></param>
        /// <returns>Rotated string segments</returns>
        public static string StringRotation(string originalString, int offset)
        {
            if (String.IsNullOrEmpty(originalString)) return string.Empty;
            if (offset <= 0) return originalString;
            if (offset >= originalString.Length) return originalString;

            string segmentToRotate = string.Empty;
            int segmentIndex = 0;
            StringBuilder builder;

            segmentIndex = originalString.Length - offset;
            segmentToRotate = originalString.Substring(segmentIndex);
            builder = new StringBuilder(segmentToRotate);
            builder.Append(originalString.Substring(0, segmentIndex));

            return builder.ToString();
        }
    }
}
