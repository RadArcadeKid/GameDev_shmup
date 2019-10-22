# Game Development Progress - SHMUP 

![Final Screenshot!](/BUILD_1_0/2019-10-21%2013_16_30-shmup%20-%20Main%20-%20PC%2C%20Mac%20%26%20Linux%20Standalone%20-%20Unity%202019.2.6f1%20Personal%20_DX11_.png)


---

# Final Entry - 10/21/2019
* There are now multiple enemies on the board - 
* ALL have thier own unique music tracks, projectilies, and THEY SPAWN TO THE MUSIC 
* Enemies all have their own unique movement system
* More aesthetically pleaing and clear health bars
* Assets are now actual art instead of more placeholders
* There is an audience the player can shove-around and interact with at a very basic level (more for visual aesthetics than anything else) 
* Adjusted difficultly curve to make the shmup easier to play
* Ironed out some bugs and weird boundary issues I had with collision 


### Notes on the final build:

I'm pretty happy with how this turned out, but man, I really wish I had more time on this thing.
It turned into way-more of a bullet-hell than I was expecting! Regradless, I feel like this absolutely put *much* more of an emphasis on survival and quick-thinking dodging + strategy than I was expecting. Honestly though, this plays into the design goal of making the player feel overwhelmed, which I really like. It encourages survival and quick-timing thinking with dodging the variety of projectiles. 
Also - there's so many other little small mechanics I wanted to add that I simply just did not have time for...I really wanted to expand on this with multiple levels/songs, weird powerups, and more interesting ways to have the enemies interact. The final product is nice, but it's not where I totally wanted it to be! I had an idea where the player could replenish health with a vending machine, obtain "earplugs" to pause the music or that would clear all projectiles. Oh well.
I also wanted to expand on the idea of making it more rythm-based (i.e. the player could only shoot to the beat, or move to the beat). 


---

# Midpoint Entry - 9/09/2019
* Enemy shoots at player
* Single enemy on the board
* Basic random movement system for enemy 
* Enemy is able to use the FFT (Fast-Fourier Transform) to shoot at the player *BASED ON MUSIC!!* 
* (Need to figure out how to get the above working with multiple audio sources)
* Basic movement system is ironed-out
* Player and Enemy have health bars 
* Started work on finishing placeholder art and ideas
* Audience member assets are in place (static, non-interactive) 

I really want to add more enemies and more interesting projectiles for the player to dodge. As this game gets more interesting, I want to add less placeholder art and more interesting ways to dodge the bullets!! 

---

### Brainstorming Ideas, initial setup

I originally had quite a few ideas when it came to building this whole shmup from the ground up, however, what I did know was that it was going to be music based, because I have a passion for music and sound. So, eventually, I stumbled upon the idea of making the shmup where you're a concert attendee who must survive a series of **EVIL BANDS** who attack the player to music-timed projectiles. I've thought about doing this as a first-person shooter for a while, but I think a rythm-based 3rd-person shmup lends itself much better to this idea. Instead of suriving through waves of enemies on a moving platform like most shmups, you're trapped in a concert venue, and the goal of this is to create a big boss battle wherre you move around the concert floor and attempt to shoot the moving DJ's up top. 



The unique (well, maybe not entirely *unique* but most interesting thing) of this game is that the projectiles are all timed to music - so if you've got a song playing, the drummer's projecticles are timed to the drums of a song, the guitarists are shot in time with the music. Each of the band members' projectiles will be different, too, but all will be timed to the music. 



I am also planning on adding more bands and even a DJ depending on the style of the music. Electronic music is repetative and lends itself well to something like this. 
As far as the visual-style goes, I think this lends itself well to a top-down pixel-art setting. I *could* do this with 3D renders but I think the visual style and presentation would be more fun with pixel-art. 

---


# Change Log: 

## 9/25/2019
Started work on Shmup project using the book as a reference. Added basic movement, placeholder assets, 
Because my game is different than the one being built,
I'm attempting to scope it a little differently than the one the author is building. 

#### Key differences: 
* Has square boundaries instead of a rectangle
* The player moves in x and y and does not rotate or move along the z axis
* There is no shield mechanic (doesn't fit what I'm going for right now)
* The player movement is more tight and fast rather than weighty and heavy 
* Does not have paralax scrolling
* Has enemies timed to/spawning to music/timing
* Does not have powerups (yet)

I also still need to implement more assets and get the game looking how I want. Currently using placeholder assets and basic stuff to get the mechanics down first.
#### Stretch-goals: 
* Make it pretty (add real assets + art)
* Add more solid movement mechanics to enemies 
* Figure out a way to restrict the player's movement based on the arena (better boundaries) 
* Have enemies moving across the top of the screen on a stage, rather than spawning in
* (Long-term goal) Implement a rewind/music based powerup which lets the player rewind/stop time for a few seconds 

---

## 9/23/2019
Initialized this repository, created basic game files. (Recreated because I did it really wrong the first time)
