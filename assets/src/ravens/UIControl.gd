extends Control
const Raven = preload("res://assets/src/ravens/Raven.cs")
const Bank = preload("res://assets/src/currency_handling/Bank.cs")

var raven: Raven = null
var bank : Bank = Bank.new()

@export var money :Label
@export var strengthLevel :Label
@export var intelligenceLevel :Label
@export var constitutionLevel :Label
@export var perceptionLevel :Label
@export var craftingLevel :Label
@export var dexterityLevel :Label
@export var strengthCost :Label
@export var intelligenceCost :Label
@export var constitutionCost :Label
@export var perceptionCost :Label
@export var craftingCost :Label
@export var dexterityCost :Label

func _ready():
	var cur = self
	while raven == null:
		cur = cur.get_parent()
		if cur.is_in_group("Raven"):
			raven = cur 
			
	update_ui()
	
func _process(_delta):
	money.set_text(str(bank.get_food()))
	
	if Input.is_action_just_pressed("close"):
		self.visible = false

func update_ui():
	strengthLevel.set_text(str(raven.get_skill_level_from_string("strength")))
	strengthCost.set_text(str(raven.get_skill_price_from_string("strength")))
	intelligenceLevel.set_text(str(raven.get_skill_level_from_string("intelligence")))
	intelligenceCost.set_text(str(raven.get_skill_price_from_string("intelligence")))
	constitutionLevel.set_text(str(raven.get_skill_level_from_string("constitution")))
	constitutionCost.set_text(str(raven.get_skill_price_from_string("constitution")))
	perceptionLevel.set_text(str(raven.get_skill_level_from_string("perception")))
	perceptionCost.set_text(str(raven.get_skill_price_from_string("perception")))
	craftingLevel.set_text(str(raven.get_skill_level_from_string("crafting")))
	craftingCost.set_text(str(raven.get_skill_price_from_string("crafting")))
	dexterityLevel.set_text(str(raven.get_skill_level_from_string("dexterity")))
	dexterityCost.set_text(str(raven.get_skill_price_from_string("dexterity")))

func upgrade_strength():
	raven.upgrade_skill_with_name("strength", bank)
	update_ui()
	
func upgrade_intelligence():
	raven.upgrade_skill_with_name("intelligence", bank)
	update_ui()
	
func upgrade_constitution():
	raven.upgrade_skill_with_name("constitution", bank)
	update_ui()
	
func upgrade_perception():
	raven.upgrade_skill_with_name("perception", bank)
	update_ui()
	
func upgrade_crafting():
	raven.upgrade_skill_with_name("crafting", bank)
	update_ui()
	
func upgrade_dexterity():
	raven.upgrade_skill_with_name("dexterity", bank)
	update_ui()
