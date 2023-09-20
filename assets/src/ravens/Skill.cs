namespace ProjectRaven.assets.src.ravens; 

public class Skill {

    private int level;

    public Skill(int init_level = 0) {
        level = init_level;
    }

    public void upgrade() {
        level++;
    }

    public int get_level() {
        return level;
    }

}