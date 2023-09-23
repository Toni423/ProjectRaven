extends Button

const Raven = preload("res://assets/scenes/Raven.tscn")

@export var ravenHolder: RavenHolder

func button_press():
	var raven = Raven.instantiate()
	get_tree().root.add_child(raven)
	raven.position = get_global_mouse_position() 
	ravenHolder.ravens.push_back(raven)
