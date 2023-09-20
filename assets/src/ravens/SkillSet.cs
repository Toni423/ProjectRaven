using System.Collections.Generic;

namespace ProjectRaven.assets.src.ravens;

public enum SkillNames {
    STRENGTH,
    INTELLIGENCE,
    CONSTITUTION,
    PERCEPTION,
    CRAFTING,
    DEXTERITY
}

public class SkillSet {

    private Dictionary<SkillNames, Skill> skills = new Dictionary<SkillNames, Skill>();

    public SkillSet(int strength = 0, int intelligence = 0, int constitution = 0, int perception = 0, int crafting = 0, int dexterity = 0) {
        skills.Add(SkillNames.STRENGTH, new Skill(strength));
        skills.Add(SkillNames.INTELLIGENCE, new Skill(intelligence));
        skills.Add(SkillNames.CONSTITUTION, new Skill(constitution));
        skills.Add(SkillNames.PERCEPTION, new Skill(perception));
        skills.Add(SkillNames.CRAFTING, new Skill(crafting));
        skills.Add(SkillNames.DEXTERITY, new Skill(dexterity));
    }

    public void upgrade_skill(SkillNames name) {
        skills[name].upgrade();
    }

    public int get_level(SkillNames name) {
        return skills[name].get_level();
    }

}