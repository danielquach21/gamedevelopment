if (keyboard_check_pressed(vk_f10) || gamepad_button_check_pressed(0,gp_select))
   {
   if window_get_fullscreen()
      {
      window_set_fullscreen(false);
      }
   else
      {
      window_set_fullscreen(true);
      }
   }
   
if(keyboard_check_pressed(ord("R"))){
	game_restart();
}