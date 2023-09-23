using Godot;

namespace ProjectRaven.assets.src.currency_handling; 

public partial class Bank : Node {
	private static double food = 0;
	private static string configFFilePath = "user://playerConfig.cfg";

	[Export] 
	public string playerName = "Player1";


	public override void _Ready() {
		load_food();
		food = 100;
	}

	public void load_food() {
	 	ConfigFile config = new ConfigFile();
		if (config.Load(configFFilePath) != Error.Ok) {
			return;
		}
		
		food = (double) config.GetValue(playerName, "food");
	}

	public void save_food() {
		ConfigFile config = new ConfigFile();
		config.SetValue(playerName, "food", food);
		config.Save(configFFilePath);
	}

	public void print_food() {
		GD.Print(food);
	}

	public double get_food() {
		return food;
	}

	
	private static readonly object locker = new();
	public void add_food(int amount) {
		lock (locker) {
			food += amount;
		}
	}
	
	public static bool buy(double cost) {
		lock (locker) {
			if (food < cost) {
				return false;
			}

			food -= cost;
			return true;
		}
	}
	
}
