room_goto(MainMenu);
score1 = 0;
score2 = 0;
score3 = 0;
score4 = 0;
if(instance_exists(player1)){
	player1.visible = false;
}

if(instance_exists(player2)){
	player2.visible = false;
}
if(instance_exists(player3)){
	player3.visible = false;
}
if(instance_exists(player4)){
	player4.visible = false;
}
audio_play_sound(sound_select, 1, false);