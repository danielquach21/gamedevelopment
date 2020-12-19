/// @description Dog Jam
// You can write your code in this editor
if((player1.danceMoves > player2.danceMoves) && (player1.danceMoves > player3.danceMoves) && (player1.danceMoves > player4.danceMoves)){
	score1 = score1 + 1;
	obj_score1.image_index = obj_score1.image_index + 1;
}else if((player2.danceMoves > player1.danceMoves) && (player2.danceMoves > player3.danceMoves) && (player2.danceMoves > player4.danceMoves)){
	score2 = score2 + 1;
	obj_score2.image_index = obj_score2.image_index + 1;
}else if((player3.danceMoves > player1.danceMoves) && (player3.danceMoves > player2.danceMoves) && (player3.danceMoves > player4.danceMoves)){
	score3 = score3 + 1;
	obj_score3.image_index = obj_score3.image_index + 1;
}else if((player4.danceMoves > player1.danceMoves) && (player4.danceMoves > player2.danceMoves) && (player4.danceMoves > player3.danceMoves)){
	score4 = score4 + 1;	
	obj_score4.image_index = obj_score4.image_index + 1;
}

if(score1 == gameMode){
	currentRoom = finalScreen;
	room_goto(finalScreen);
	player1.x = 960;
	player1.y = 540;
	player2.visible = false;
	player3.visible = false;
	player4.visible = false;
}else if(score2 == gameMode){
	currentRoom = finalScreen;
	room_goto(finalScreen);
	player2.x = 960;
	player2.y = 540;
	player1.visible = false;
	player3.visible = false;
	player4.visible = false;
}else if(score3 == gameMode){
	currentRoom = finalScreen;
	room_goto(finalScreen);
	player3.x = 960;
	player3.y = 540;
	player2.visible = false;
	player1.visible = false;
	player4.visible = false;
}else if(score4 == gameMode){
	currentRoom = finalScreen;
	room_goto(finalScreen);
	player4.x = 960;
	player4.y = 540;
	player1.visible = false;
	player3.visible = false;
	player2.visible = false;
}else{
	currentRoom = GameStart;
	room_goto(GameStart);
		player1.x = 160;
		player1.y = 960;
		player2.x = 640;
		player2.y = 960;
		player3.x = 1152;
		player3.y = 960;
		player4.x = 1632;
		player4.y = 960;
}