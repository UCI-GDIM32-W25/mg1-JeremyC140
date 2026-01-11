# HW1
## Devlog
### My name: 
Jeremy Chang, he / him

### MG1 Reflection:
It turns out the building process went more smoothly and less complicated than I imagined during class planning time (maybe that I was anticipating a true "starting from scratch" opportunity, which would actually be much more painful tbh XD). As a result, this is a very simple game, and the planning I came up with my teammate went almost 100% correct. 
We anticipated an UI gameObject (which is the Canvas built in already for us) with some TMP texts, which are then interconnected with the player's script to update the variables; our brief mentions of player script's member variables turned out to cover quite comprehensively, with the number of drops, speeds, etc.; We didn't write out the method for plantingSeeds but it was kinda expected since it's an efficient way to share information with the UI script and variables update. It was also where I faced a minor problem, with the method Instantiate. After researching and refreshing my memories on this method, I then realized it requires three arguments, with the third one Quaternion.identity(sth with rotation) being mandatory when the position to spawn the prefab is specified. This reinforces my knowledge on prefab and Instantiate. 

## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites
