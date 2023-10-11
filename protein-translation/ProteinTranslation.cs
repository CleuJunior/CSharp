using System;
using System.Collections.Generic;
using System.Linq;

public static class ProteinTranslation
{
    public static string[] Proteins(string strand)
    {
        if (StopProtein(strand))
            return Array.Empty<string>();

        ICollection<string> proteins = new List<string>();
        string protein = "";

        foreach (var c in strand)
        {
            protein += c;
            if (protein.Length != 3)
                continue;

            if (StopProtein(protein))
                break;

            switch (protein)
            {
                case "AUG":
                    proteins.Add("Methionine");
                    break;
                case "UUU" or "UUC":
                    proteins.Add("Phenylalanine");
                    break;
                case "UUA" or "UUG":
                    proteins.Add("Leucine");
                    break;
                case "UCU" or "UCC" or "UCA" or "UCG":
                    proteins.Add("Serine");
                    break;
                case "UAU" or "UAC":
                    proteins.Add("Tyrosine");
                    break;
                case "UGU" or "UGC":
                    proteins.Add("Cysteine");
                    break;
                case "UGG":
                    proteins.Add("Tryptophan");
                    break;
            }

            protein = "";
        }

        return proteins.ToArray();
    }

    private static bool StopProtein(string strand) =>
        string.IsNullOrWhiteSpace(strand) || strand.Equals("UAA") || strand.Equals("UAG") ||
        strand.Equals("UGA");
}