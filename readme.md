# bleep-drill
**bleep-drill** is a Windows Forms project written in Visual Basic. You can use it as a customisable beep test in fitness training. It has a very simple, very usable interface, with nothing unecessary added.

## Build

* Make a new VB project;
* In Solution Explorer, right-click the project, and Add Existing Item...
* Add the vb files from this repo;
* Go to project properties, and set Main.vb as the startup object;
* Build.
	* Put the wav files in the project output folder (bin)

## Run

To create a routine, click More (or press Alt+M), fill in the first interval, and repeat as necessary. If you make a mistake, click Less.

On the right, set the number of times you want to do the routine, or tick forever (if you do, you might have to close the program by right-clicking it on the taskbar)
  
Click Go or press Alt+G when you’re ready to begin.
 
### Sound
The program plays a begin tone (do-DOOP), beeps to your specifications, and when it has done the loop x times as specified, it plays the end tone to let you know it’s done (DOO-dup).
 
To change the sounds, replace the wav files. If the wav files are missing, **bleep-drill** uses the Windows 'asterisk' sound for all 3 tones. 