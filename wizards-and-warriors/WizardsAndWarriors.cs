using System;

abstract class Character
{
    private readonly string _characterType;
    protected bool IsVulnerable;

    protected Character(string characterType)
    {
        this._characterType = characterType;
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable() => IsVulnerable;

    public override string ToString()
    {
        return $"Character is a {_characterType}";
    }
}

class Warrior : Character
{
    public Warrior() : base("Warrior")
    {
    }

    public override int DamagePoints(Character target) => target.Vulnerable() ? 10 : 6;
}

class Wizard : Character
{
    public Wizard() : base("Wizard")
    {
    }

    public override int DamagePoints(Character target) => base.IsVulnerable ? 12 : 3;

    public void PrepareSpell() => base.IsVulnerable = true;

    public override bool Vulnerable() => !base.IsVulnerable;
}