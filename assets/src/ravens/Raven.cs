using System;
using Godot;
using ProjectRaven.assets.src.currency_handling;

namespace ProjectRaven.assets.src.ravens;



public partial class Raven : CharacterBody2D {
	
	private SkillSet skillSet;
	private bool mouse_entered = false;

	[Export] private Control menu;
	
	public Raven() {
		skillSet = new SkillSet();
	}

	public bool check_skill_level(SkillNames name, int level) {
		return skillSet.get_level(name) >= level;
	}

	private SkillNames string_to_skill_name(string name) {
		SkillNames skill = name switch {
			"strength" => SkillNames.STRENGTH,
			"intelligence" => SkillNames.INTELLIGENCE,
			"constitution" => SkillNames.CONSTITUTION,
			"perception" => SkillNames.PERCEPTION,
			"crafting" => SkillNames.CRAFTING,
			"dexterity" => SkillNames.DEXTERITY,
			_ => throw new Exception("invalid skill name")
		};
		return skill;
	}

	public double get_skill_price_from_string(string name) {
		return skillSet.get_price(string_to_skill_name(name));
	}

	public int get_skill_level_from_string(string name) {
		return skillSet.get_level(string_to_skill_name(name));
	}
	
	public bool upgrade_skill(SkillNames name, Bank bank) {
		return skillSet.upgrade_skill(name, bank);
	}

	public bool upgrade_skill_with_name(string name, Bank bank) {
		return upgrade_skill(string_to_skill_name(name), bank);
	}

	
	private void _on_mouse_entered() {
		mouse_entered = true;
	}


	private void _on_mouse_exited() {
		mouse_entered = false;
	}

	public override void _Process(double delta) {
		if (mouse_entered && Input.IsActionJustPressed("leftClick")) {
			menu.Visible = !menu.Visible;
		}
	}
}





