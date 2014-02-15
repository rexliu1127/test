public static DataTable getDistinctTable(DataTable dtSource, string strDistinctColumnName)
{
    DataTable dt = new DataTable();
    try
    {
        dt = dtSource.DefaultView.ToTable(true, new string[] { strDistinctColumnName });
        return dt;
    }
    catch (Exception)
    {

        return dt;
    }
}
