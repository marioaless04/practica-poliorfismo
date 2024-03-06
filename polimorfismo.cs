using System;

public abstract class Beyblade
{
    public virtual string rotar()
    {
        return "Beyblade rotando";
    }
    public abstract string evolucionar();
}
public class Pegasus : Beyblade
{
    public override string rotar()
    {
        return "Pegasus rotando";
    }
    public override string evolucionar()
    {
        retutn "Pegasus evolucionando";
    }
}
public class Virgo : Beyblade
{
    public override string rotar()
    {
        return "Virgo rotando";
    }
    public override string evolucionar()
    {
        retutn "Virgo evolucionando";
    }
}
