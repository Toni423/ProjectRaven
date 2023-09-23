using System;
using Godot;
using ProjectRaven.assets.src.currency_handling;

namespace ProjectRaven.assets.src.ravens; 

public class Skill {

	private int level;
	private int basePrice = 10;

	public Skill(int init_level = 0) {
		level = init_level;
	}

	public bool upgrade(Bank bank) {
		if (Bank.buy(get_upgrade_price()) == false ) {
			return false;
		}
		level++;
		return true;
	}

	public int get_level() {
		return level;
	}

	public double get_upgrade_price() {
		return basePrice * Math.Pow(2, level);
	}

}
