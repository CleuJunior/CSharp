static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        string owner = "OWNER";
        string idPart = id.HasValue ? $"[{id}] - " : string.Empty;
        string departmentPart = department != null ? department.ToUpper() : owner;
            
        return $"{idPart}{name} - {departmentPart}";

    }
}