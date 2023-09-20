using Godot;

namespace ProjectRaven.assets.src.ravens;

public abstract partial class Raven : Node2D {
	
	private SkillSet skillSet;

	public Raven() {
		skillSet = new SkillSet();
	}

	public bool check_skill_level(SkillNames name, int level) {
		return skillSet.get_level(name) >= level;
	}
	
}
