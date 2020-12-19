/// @description Insert description here
// You can write your code in this editor
rand = irandom(2);

counter++;
if(counter > 1){
if(lastPlayed == 0){
	if(rand == 0){
		rand = rand + irandom_range(1,2);
	}
}else if(lastPlayed == 1){
	if(rand == 1){
		randomNumber = irandom(2);
		if(randomNumber == 1){
			rand = rand - 1;
		}else if(randomNumber == 0){
			rand = rand + 1;
		}
	}
}else if(lastPlayed == 2){
	if(rand == 2){
	rand = rand - irandom_range(1,2);
	}

}
}

if(lastPlayed == 0){
	if(lastLastPlayed == 1){
		rand = 2;
	}
}else if(lastPlayed == 1){
	if(lastLastPlayed == 2){
		rand = 0;
	}
}else if(lastPlayed == 0){
	if(lastLastPlayed == 2){
		rand = 1;
	}
}

if(counter == 1){
lastLastPlayed = 4; 
lastPlayed = rand;
}else{
lastLastPlayed = lastPlayed;
lastPlayed = rand;
}
image_index = rand;
image_speed = 0;
audio_play_sound(game_select, 1, false);
alarm[1] = 3*room_speed;

