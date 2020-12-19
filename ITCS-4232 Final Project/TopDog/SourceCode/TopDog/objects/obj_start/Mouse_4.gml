room_goto(GameStart);
currentRoom = GameStart;
if(instance_exists(obj_score1)){
	
obj_score1.image_index = 0;
obj_score2.image_index = 0;
obj_score3.image_index = 0;
obj_score4.image_index = 0;
}

if(instance_exists(player1)){
	player1.visible = true;
}
if(instance_exists(player2)){
	player2.visible = true;
}
if(instance_exists(player3)){
	player3.visible = true;
}
if(instance_exists(player4)){
	player4.visible = true;
}
audio_play_sound(sound_select, 1, false);