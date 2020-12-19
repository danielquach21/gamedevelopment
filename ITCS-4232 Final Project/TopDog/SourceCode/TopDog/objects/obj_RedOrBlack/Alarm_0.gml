rand = irandom(1);
if(rand == 0){
	image_index = 1;
	if(obj_red.image_index ==1){
	player1.guesses++;
	audio_play_sound(game_select, 1, false);
	}
}else if(rand == 1){
	image_index = 2;
	if(obj_black.image_index ==1){
	player1.guesses++;
	audio_play_sound(game_select, 1, false);
}
}
alarm[1] = 1*room_speed;