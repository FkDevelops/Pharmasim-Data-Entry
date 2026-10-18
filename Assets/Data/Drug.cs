
//Drug Class
class Drug
{
    public int Din { get;}
    public string ChemicalName { get;}
    public int Strength { get;} 
    public string DosageForm { get;}
    public bool IsControlled { get;}
    public bool RequiresRx { get;}



    //Class Constructor
    public Drug(int din, string chemicalName, int strength, string dosageForm, bool isControlled, bool requiresRx)
    {
        Din = din;
        ChemicalName = chemicalName;
        Strength = strength;
        DosageForm = dosageForm;
        IsControlled = isControlled;
        RequiresRx = requiresRx;
    }
}