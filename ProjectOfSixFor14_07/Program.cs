/*
 * Created by SharpDevelop.
 * User: Viki_PC
 * Date: 13/07/2023
 * Time: 17:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;   //Microsoft Excel 14+ object is needed. This uses the 16. Ver. 1.9.
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;

namespace ProjectOfSixFor14_07
{
	class Program
	{
		public static void Main(string[] args)
		{
			string Time = DateTime.Now.ToString("HH:mm:ss");
			PrintMenu();
			Console.Write(" ---------------\n ---> Select exercise (\"1.\" <-> \"6.\"): ");
			string InputMenuChoice = Console.ReadLine();
			do
			{
				switch (InputMenuChoice)
				{
					case ("1."):
						{
							Console.WriteLine("\n============ LOADING ============\n ------ Exercise 1: String mirror using Stack ------");
							Console.Write("String to mirror (Use spaces to separate if it is multiple words): ");
							string SentenceEx1 = Console.ReadLine();
							Stack<string> Reverse = new Stack<string>();
						RepeatEx1:
							Console.Write("  -!- --- Mirror methods --- -!- \n I. Mirror word order;\n II. Mirror all chars.\n--> Choose a method to mirror (Write \"1.\" or \"2.\"): ");
							string choiceEx1 = Console.ReadLine();
							switch (choiceEx1)
							{
								case "1.": // WORD MIRROR, BUT LETTERS ARE IN SAME ORDER
									{
										string[] ex1 = SentenceEx1.Split(' ');
										foreach (var a in ex1)
										{
											Reverse.Push(a);
										}
										Console.WriteLine(" === Result: ===\n Mirrored string: ");
										while (Reverse.Count > 0)
										{
											Console.Write(Reverse.Pop() + " ");
										}
										break;
									}
								case "2.": //TOTALLY REVERSE THE STRING!
									{
										char[] CharEx1 = SentenceEx1.ToCharArray();
										foreach (char a in CharEx1)
										{
											Reverse.Push(Convert.ToString(a));
										}
										Console.WriteLine(" === Result: ===\n Mirrored string: ");
										while (Reverse.Count > 0)
										{
											Console.Write(Reverse.Pop());
										}
										break;
									}
								default:
									{
										Console.WriteLine("-!- Sorry, but your input wasn't correct. Either \"1.\" or\"2.\" are accepted! Try again please! -!-");
										goto RepeatEx1;
									}
							}
							Console.WriteLine();
							break;
						}
					case ("2."):
						{
							List<int> Ex2Pyramid = new List<int>();
							Console.WriteLine("\n============ LOADING ============\n ------ Exercise 2: Number x 5 Pyramid - Using Recursion ------");
							Console.Write("Insert number as a bottom of the pyramid (it will be multiplied x 5, Interval: [1;19] - even numbers): ");
							int n = int.Parse(Console.ReadLine());
							if ((n>0)&&(n<20)&&(n%2.0==0))
							{
								PyramidNumx5(n, n, Ex2Pyramid);
								ShowPyramid(n, Ex2Pyramid);
							}
							else
							{
								Console.WriteLine("-!- Due to limitations and issues with Log10, the interval the program works is [1;10]. -!-");
							}
							break;
						}
					case ("3."):
						{
							Console.WriteLine("\n============ LOADING ============\n ------ Exercise 3: Geometry - Using 11 classes and Math ------");
							try
							{
								Console.WriteLine("=== MENU ===");
								Console.WriteLine(" --> 1. Make Circle and Show\n --> 2. Make Rectangle and Show\n --> 3. Make Triangle and Show\n --> 4. Make Isosceles Trapezoid and Show\n --> 5. Make Correct Pyramid and Show\n --> 6. Make Rectangular Parallelepiped and Show\n --> 7. Make Right Circular Cylinder and Show\n --> 8. Make Right Circular Cone and Show\n --> 9. Make Right Circular Truncated Cone and Show\n --> 10. Make Sphere and Orb and Show\n --> 11. \"End\" to terminate the exercise.");
								Console.WriteLine("=> Choose one of them until you write 'End' or '11.'.");
								Console.Write(" -> Select function: ");
								string input = Console.ReadLine();
								do
								{
									if (input == "11.")
									{
										break;
									}
									switch (input)
									{

										case ("1."):
											{
												Figure fig = new Figure("1.");
												break;
											}
										case ("2."):
											{
												Figure fig = new Figure("2.");
												break;
											}
										case ("3."):
											{
												Figure fig = new Figure("3.");
												break;
											}
										case ("4."):
											{
												Figure fig = new Figure("4.");
												break;
											}
										case ("5."):
											{
												Figure fig = new Figure("5.");
												break;
											}
										case ("6."):
											{
												Figure fig = new Figure("6.");
												break;
											}
										case ("7."):
											{
												Figure fig = new Figure("7.");
												break;
											}
										case ("8."):
											{
												Figure fig = new Figure("8.");
												break;
											}
										case ("9."):
											{
												Figure fig = new Figure("9.");
												break;
											}
										case ("10."):
											{
												Figure fig = new Figure("10.");
												break;
											}
										default:
											{
												Console.WriteLine("-!- Sorry, input is incorrect-!-");
												break;
											}
									}
									Console.Write(" -> Select function: ");
									input = Console.ReadLine();
								}
								while (((input.ToUpper() != "END") || (input != "11.")));
							}
							catch (ArgumentException e)
							{
								Console.WriteLine("{0}: {1}", e.GetType().Name, e.Message);
							}

							break;
						}
					case ("4."):
						{
							System.Media.SoundPlayer player = new System.Media.SoundPlayer();
							player.SoundLocation = "Mario Forever World 1-4 (Yoshi's Island Castle) Music.wav";
							player.PlayLooping();
							Levelup lvlup = new Levelup();
							lvlup.Level = 1;
							lvlup.Exp = 0;
							lvlup.XpNeeded = 20;
						Repeat:
							Console.WriteLine("\n============ LOADING ============\n -- Music playing: Yoshi's Island castle - Remix\n ------ Exercise 3: In the Darkest Castle Extended v.3.0.β ------");
							List<string> Names = new List<string>();
							Names.Add("Frisk");
							Names.Add("Chara");
							Names.Add("Mario");
							int Health = 100;
							int Coins = 0;
							int LootPercentIncrease = 0;
							int FuelNeededToMaxTorch = 2;
							Console.WriteLine(" -------------------\n  ==== Plot: ==== \nYou move in a new city. You decide to explore and see what the city is like. Soon enough, you find a dark castle. It has a label:\"The Darkest Castle\". You meet a passerby and ask him about the mysterious building. They warn you not to get in because \"No one has returned... Be cautious: There are monsters in it!\". But you like challenges. You decide to enter the building.\n--- BEST OF LUCK! ---");
							Console.WriteLine(" === HOW TO TYPE IN THE INPUT: === \n -> \"|\"\n -> Commands:\n\t---> explore;\n\t---> torch;\n\t---> potion (if needed add type mentioned below, but number is NEEDED):\n\t\t --> P-1. normal;\n\t\t --> P-2. heal;\n\t\t --> P-3. rage;\n\t\t --> P-4. multi;\n\t\t --> P-5. poison;\n\t---> chest[-key] (Add number, it is NEEDED);\n\t---> \"(Monster Name)\" (Add Number for DMG) [-!- 'Frisk/Chara/Sans/Mario' are buddies you can find in the castle! -!-]\n -> \"|\" \n -- Fun fact: Repeat as many times as you want :D --");
							Console.WriteLine("===================================================================\n----- Player Progress: -----");
							int RoomCount = 1; //explore|potion-heal 13|torch|chest 13|chest-key 134|Frisk|Monster 19|Frisk|Chara|potion-rage 19|explore|Sans 81|potion-heal 10|torch
							string[] AmountOfText;
							var rooms = Console.ReadLine().Split('|');
							Console.WriteLine("------------- Let's go! ------------- \n");
							List<string> Counter = new List<string>();
							List<int> Value = new List<int>();
							foreach (var a in rooms)
							{
								AmountOfText = a.Split(' ');
								string CommandorName = AmountOfText[0];
								Counter.Add(CommandorName);
								if (!((CommandorName == "explore") || (CommandorName == "torch") || (CommandorName == "Frisk") || (CommandorName == "Chara") || (CommandorName == "Mario")))
								{
									string ValueNum = AmountOfText[1];
									Value.Add(int.Parse(ValueNum));
								}
								else
								{
									Value.Add(0);
								}
								if (lvlup.Exp >= lvlup.XpNeeded)
								{
									lvlup.XpNeeded *= 2;
									do
									{
										lvlup.Exp = lvlup.Exp - lvlup.XpNeeded;
										lvlup.Level += 1;
									}
									while (lvlup.Exp >= lvlup.XpNeeded);
								}
							}
							for (int i = 0; i < Counter.Count; i++)
							{
								switch (Counter[i])
								{
									case "torch":
										{
											if (FuelNeededToMaxTorch >= 0)
											{
												if (FuelNeededToMaxTorch==2)
												{
													Console.WriteLine(" -> You've found a torch, laying on a pillar. Now you can see better your surroundings. Loot increased with 5%. {0} fuel needed to max out your torch. You see a sign next to it. You realize this one doesn't fade away like others, it is cursed in a good way. It can help you escape the castle! Just keep the torch in your hand!", FuelNeededToMaxTorch);
													Console.WriteLine(" -- Torch equipped in left hand. Level {0}/{1} --", 3 - FuelNeededToMaxTorch, 3);
												}
												else
												{
													Console.WriteLine(" -- Torch powered. Level {0}/{1} --", 3 - FuelNeededToMaxTorch, 3);
												}
												LootPercentIncrease += 5;
												FuelNeededToMaxTorch--;
											}
											else
											{
												Console.WriteLine(" -!- Nice try, but: 1) Torch light level is maxed out. 2) Loot Increase % has reached the maximum! -!-");
											}
											break;
										}
									case "potion-heal":
										{
											string PotionName = Counter[i];
											if (Health > 0)
											{
												int Heal = Value[i];
												if (Health + Heal <= 100)
												{
													Console.WriteLine(" -> You restored (healed) {0} HP.", Heal);
													Health += Heal;
													Console.WriteLine(" -- Current health: {0}/100 HP. --", Health);
												}
												else
												{
													Console.WriteLine(" -> (Heal set from {1} to {0}) You restored (healed) {0} HP.", 100 - Health, Heal);
													Health = Health + (100 - Health);
													Console.WriteLine(" -- Current health: {0}/100 HP. --", Health);
												}
												RoomCount++;
											}
											break;
										}
									case "potion-poison":
										{
											if (Health > 15)
											{
												Health -= 15;
												Console.WriteLine(" -> You have been poisoned... Lost 15 health. Be more careful, they are literally labeled \"poison\", baka idiot stupid.");
												RoomCount++;
											}
											else
											{
												Console.WriteLine("\n-- 2-2. Game over screen --");
												Console.WriteLine("----- You died from your poison potion... Pathetic. --- (--!-- Why would you pick one?! --!--) \n Best room in this program run: {0}/{1}\n --- Stats: ---\nCoins: {2}\nLevel: {3} ({4}/{5} XP)", RoomCount, RoomCount++, Coins, lvlup.Level, lvlup.Exp, lvlup.XpNeeded);
											}
											break;
										}
									case "potion-rage":
										{
											Console.WriteLine(" -> Your damage has increased by {0}%!", Value[i]);
											RoomCount++;
											break;
										}
									case "potion-multi":
										{
											if (Health > 0)
											{
												int Heal = 50;
												if (Health + Heal <= 100)
												{
													Console.WriteLine(" -> [Heal set to 50] You restored (healed) {0} HP.", Heal);
													Health += Heal;
													Console.WriteLine(" -- Current health: {0}/100 HP. --", Health);
												}
												else
												{
													Console.WriteLine(" -> You restored (healed) {0} HP.", 100 - Health);
													Health = Health + (100 - Health);
													Console.WriteLine(" -- Current health: {0}/100 HP. --", Health);
												}
											}
											Console.WriteLine(" -!- Your damage has also increased by 50% for 2 rooms! -!-");
											RoomCount++;
											break;
										}
									case "potion":
										{
											Console.WriteLine(" -!- It did almost nothing no matter you wrote a number... -!-");
											RoomCount++;
											break;
										}
									case ("chest"):
										{
											if (Health >= 0)
											{
												int ChestContainedCoins = Value[i] * ((100 + LootPercentIncrease) / 100);
												Coins += ChestContainedCoins;
												Console.WriteLine(" -> You have just found {0} Coins!", ChestContainedCoins);
												RoomCount++;
											}
											break;
										}
									case ("chest-key"):
										{
											if (Health >= 0)
											{
												int ChestContainedCoins = Value[i] * ((100 + LootPercentIncrease) / 100) + 250;
												Coins += ChestContainedCoins;
												Console.WriteLine(" -> You have found a locked chest. Luckily, you had a key and opened it. You have just found {0} Coins!", ChestContainedCoins);
												RoomCount++;
											}
											break;
										}
									case ("explore"):
										{
											Random rnd = new Random();
											int Rdom = rnd.Next(1, 2);
											if (Rdom == 1) // ENCOUNTER
											{
												if (Health > 0)
												{
													int DamageByMonster = rnd.Next(3, 14);
													Health -= DamageByMonster;
													if (Health > 0)
													{
														Console.WriteLine(" -> You slayed 'Unknown'. 40 XP gained. (--!-- {0}/100 HP remaining --!--)", Health);
														lvlup.Exp += 40;
														if (lvlup.YesLevelUp(lvlup.Exp, lvlup.XpNeeded, 40, lvlup.Level))
														{
															lvlup.LevelUp(lvlup.Exp, lvlup.XpNeeded, lvlup.Level);
														}
														RoomCount++;
													}
													else
													{
														Console.WriteLine("\n-- 2-2. Game over screen --");
														Console.WriteLine("----- You died! -------\n {1} HP needed to survive. --- Killed by {0}. \n Best room in this program run: {2} (Died in room {3})\n --- Stats: ---\nCoins: {7}\nLevel: {4} ({5}/{6} XP)", Counter[i], (0 - Health), RoomCount, RoomCount++, lvlup.Level, lvlup.Exp, lvlup.XpNeeded, Coins);
														break;
													}
												}
											}
											else // COINS HAVE BEEN FOUND
											{
												Random coins = new Random();
												int rndcoins = coins.Next(1, 2);
												if (rndcoins == 1)
												{
													int ChestContainedCoins = coins.Next(7, 19); //Loot increase doesn't fix this, heh >:D
													Coins += ChestContainedCoins;
													Console.WriteLine(" -> You have just found {0} Coins!", ChestContainedCoins);
												}
												else
												{
													int ChestContainedCoins = coins.Next(51, 57);
													Coins += ChestContainedCoins;
													Console.WriteLine(" -> Oh hey! Lucky! You have just found {0} Coins!", ChestContainedCoins);
												}
												RoomCount++;
											}
											break;
										}
									default:
										{
											if (Health > 0)
											{
												int DamageByMonster = Value[i];
												if (Counter[i] == "Sans")
												{
													DamageByMonster = 71;
													if (Health > 0)
													{
														if (lvlup.Level <= 4)
														{
															Health -= DamageByMonster;
															if (Health > 0)
															{
																Console.WriteLine(" -> Congratulations, you have beaten {0}! 400XP obtained! (--!-- {1}/100 HP remaining --!--)", Counter[i], Health);
																lvlup.Exp += 400;
																if (lvlup.YesLevelUp(lvlup.Exp, lvlup.XpNeeded, 400, lvlup.Level))
																{
																	lvlup.LevelUp(lvlup.Exp, lvlup.XpNeeded, lvlup.Level);
																}
																RoomCount++;
															}
															else
															{
																Console.WriteLine("\n-- 2-2. Game over screen --");
																Console.WriteLine("----- You died! -------\n {1} HP needed to survive. --- Dunked on(!) by {0}. \n Best room in this program run: {2}/{3}\n --- Stats: ---\nCoins: {4}\nLevel: {5} ({6}/{7} XP", Counter[i], (0 - Health), RoomCount, RoomCount++, Coins, lvlup.Level, lvlup.Exp, lvlup.XpNeeded);
																goto Break;
															}

														}
														else
														{
															Health -= DamageByMonster;
															if (Health > 0)
															{
																Console.WriteLine(" -> Congratulations, you have beaten {0}! 750XP obtained! (--!-- {1}/100 HP remaining --!--)", Counter[i], Health);
																lvlup.Exp += 750;
																if (lvlup.YesLevelUp(lvlup.Exp, lvlup.XpNeeded, 750, lvlup.Level))
																{
																	lvlup.LevelUp(lvlup.Exp, lvlup.XpNeeded, lvlup.Level);
																}
																RoomCount++;
															}
															else
															{
																Console.WriteLine("\n-- 2-2. Game over screen --");
																Console.WriteLine("----- You died! -------\n {1} HP needed to survive. --- Dunked on(!) by {0}. \n Best room in this program run: {2}/{3}\n --- Stats: ---\nCoins: {4}\nLevel: {5} ({6}/{7} XP", Counter[i], (0 - Health), RoomCount, RoomCount++, Coins, lvlup.Level, lvlup.Exp, lvlup.XpNeeded);
																goto Break;
																//Frisk 12|potion-multi 44|boss 69|potion-heal 19|potion 12|chest-key 100|chest 129|Chara 100|explore 12
															}

														}
													}
													else
													{
														Console.WriteLine("\n-- 2-2. Game over screen --");
														Console.WriteLine("----- Game over -------\n {1} HP needed to survive. --- Dunked on {0}. \n Best room in this program run: {2} (Died in room {3})\n --- Stats: ---\nCoins: {0}\nLevel: {4} ({5}/{6} XP)", Counter[i], (0 - Health), RoomCount, RoomCount++, lvlup.Level, lvlup.Exp, lvlup.XpNeeded);
														break;
													}
												}
												else
												{
													if ((Counter[i] == "Frisk") || (Counter[i] == "Chara") || (Counter[i] == "Mario"))
													{
														if (Names.Contains(Counter[i]))
														{
															Names.Remove(Counter[i]);
															DamageByMonster = 0;
															if (Health <= 85)
															{
																Health += 15;
															}
															else
															{
																Health = 100;
															}
															Console.WriteLine("-> You found {0} in the dungeon. They confused you as an enemy for a moment. After a short talk, you teamed up! -- Healed 15 HP and gained 400XP! -- ({1}/100 HP)", Counter[i], Health);
															lvlup.Exp += 400;
															if (lvlup.YesLevelUp(lvlup.Exp, lvlup.XpNeeded, 400, lvlup.Level))
															{
																lvlup.LevelUp(lvlup.Exp, lvlup.XpNeeded, lvlup.Level);
															}
														}
														else
														{
															Console.WriteLine(" -!- You have already found {0} in the dungeon. You tried, I guess -> Still, you obtained 50XP! -- ({1}/100 HP) -!-", Counter[i], Health);
															lvlup.Exp += 50;
															if (lvlup.YesLevelUp(lvlup.Exp, lvlup.XpNeeded, 50, lvlup.Level))
															{
																lvlup.LevelUp(lvlup.Exp, lvlup.XpNeeded, lvlup.Level);
															}
														}
														RoomCount++;
													}
													else
													{
														Health -= DamageByMonster;
														if (Health > 0)
														{
															Console.WriteLine(" -> You slayed {0}. 40 XP obtained. (--!-- {1}/100 HP remaining --!--)", Counter[i], Health);
															lvlup.Exp += 40;
															if (lvlup.YesLevelUp(lvlup.Exp, lvlup.XpNeeded, 40, lvlup.Level))
															{
																lvlup.LevelUp(lvlup.Exp, lvlup.XpNeeded, lvlup.Level);
															}
															RoomCount++;
														}
														else
														{
															Console.WriteLine("----- You died! -------\n {1} HP needed to survive. --- Killed by {0}. \n Best room in this program run: {2}/{3}\n --- Stats: ---\nCoins: {4}\nLevel: {5} ({6}/{7} XP)", Counter[i], (0 - Health), RoomCount, RoomCount++, Coins, lvlup.Level, lvlup.Exp, lvlup.XpNeeded);
															goto Break;

														}
													}
												}
											}
											break;
										}
								}
							}
							if (Health > 0)
							{
								Console.WriteLine("\n------- End --------");
								Console.WriteLine("---------- Congratulations! You've made it! --------------\n ====== Plot contuniation: ======\nYou have completed the castle, escaped alive. Even with some friends for sure! People consider you as a hero!\n -----> HAPPY ENDING <-----\n == End stats: ==\n\t --> Coins: {0}\n\t --> Health: {1}/100\n\t --> Rooms survived: {2}/{2}\n\t --> Level: {3} ({4}/{5} XP)", Coins, Health, RoomCount - 1, lvlup.Level, lvlup.Exp, lvlup.XpNeeded);
							}
						Break:
							Console.WriteLine("\n====\n= Retry? ('Yes'/'No') =");
							string retry = Console.ReadLine();
							if (retry.ToLower() == "yes")
							{
								goto Repeat;
							}
							else
							{
								player.Stop();
							}
							break;
						}
					case ("5."):
						{
							Console.WriteLine("\n============ LOADING ============\n ------ Exercise 5: Validate audio file names and extensions using Excel and REGEX ------");
							int SongCount = 1;
							List<string> MusicSaved = new List<string>();
							Console.Write("Music file name #{0} (add extension): ",SongCount);
							string namemusic = Console.ReadLine();
							do
							{
								string[] StrArray = namemusic.Split('.');
								string NameOfOST = StrArray[0];
								string Extension = "." + StrArray[1];
								int count = Extension.Count(f => f == '.');
								bool NameValid = false;
								if (Regex.IsMatch(NameOfOST, "") && (count == 1))
								{
									NameValid=true;
									Console.WriteLine("The following file name \"{0}\" has passed the REGEX.",NameOfOST);
								}
								else
								{
									Console.WriteLine("The following file name \"{0}\" turns out to be non-valid...", NameOfOST);
								}
								Excel.Application xlApp = new Excel.Application();
								Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"C:\\Users\\Trainee\\Downloads\\Audio Worksheet extensions.xls");
								Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
								Excel.Range xlRange = xlWorksheet.UsedRange;
								int rowCount = xlRange.Rows.Count;
								int colCount = xlRange.Columns.Count;
								bool extensionfound = false;
								for (int i = 1; i <= rowCount; i++)
								{
									for (int j = 1; j <= colCount; j++)
									{
										if (xlRange.Cells[i, j] != null && xlRange.Cells[i, j].Value2 != null)
										{
											if (Extension == xlRange.Cells[i, j].Value2.ToString())
											{
												extensionfound=true;
												Console.WriteLine("The extension \"{0}\" has been proved to be an audio one!", xlRange.Cells[i, j].Value2.ToString());
											}
										}
									}
								}
								if (extensionfound==false)
								{
									Console.WriteLine("-> Sadly, the file didn't pass the validation. Try again. <-[ -!- \n The extension \"{0}\" has been proved to be an audio one!", Extension);
								}
								GC.Collect();
								GC.WaitForPendingFinalizers();
								Marshal.ReleaseComObject(xlRange);
								Marshal.ReleaseComObject(xlWorksheet);
								xlWorkbook.Close();
								Marshal.ReleaseComObject(xlWorkbook);
								xlApp.Quit();
								Marshal.ReleaseComObject(xlApp);
								if (NameValid==true && extensionfound==true)
								{
									Console.WriteLine(" -> VALIDATED! Feel free to listen to it! <-");
									SongCount++;
									MusicSaved.Add(namemusic);
								}
								else
								{
									Console.WriteLine("-> Sadly, the file didn't pass the validation. Try again. <-");
								}
								Console.Write("Music file name #{0} (add extension): ",SongCount);
								namemusic = Console.ReadLine();
							}
							while (namemusic.ToLower() != "end");
							Console.WriteLine(" ------ END RESULT: ------");
							int resultnum = 1;
							foreach(var music in MusicSaved)
							{
								Console.WriteLine("Music #{0}: {1}",resultnum,music);
								resultnum++;
							}
							break;
						}
					case ("6."):
						{
							Console.WriteLine("\n============ LOADING ============\n ------ Exercise 6: Mario Minix Remake v1.0α (Unfinished) by Victor Rusev (Me, also known as ElectroDragon777 online) ------");
						StartGame:
							Process BootUp = Process.Start("C:\\Users\\Viki_PC\\OneDrive\\Desktop\\Mario Minix Remake v.1.0.exe");
							Console.WriteLine("Game started. Press \"Enter\" key to close the game and again to exit the exercise.");
							ConsoleKeyInfo key = Console.ReadKey(true);
							if (key.Key == ConsoleKey.Enter)
							{
								Console.WriteLine("Closing Mario Minix...");
							}
							Console.WriteLine("Press any key to quit, or \"Backspace\" to launch the game again.");
							ConsoleKeyInfo key1 = Console.ReadKey(true);
							if (key1.Key == ConsoleKey.Backspace)
							{
								Console.WriteLine("Opening Mario Minix...");
								goto StartGame;
							}
							else
							{
								BootUp.Close();
								break;
							}

						}
					default:
						{
							break;
						}
				}
			RepeatChoice:
				Console.WriteLine(" -- Press \"Enter\" to continue, \"Escape\" to Quit. Why? It has Console.Clear(), so it is better to see the result. --");
				ConsoleKeyInfo keycontinue = Console.ReadKey(true);
				if (keycontinue.Key == ConsoleKey.Enter)
				{
					Console.Clear();
					PrintMenu();
					Console.Write(" ---------------\n ---> Select exercise (\"1.\" <-> \"6.\"): ");
					InputMenuChoice = Console.ReadLine();
				}
				else
				{
					if (keycontinue.Key == ConsoleKey.Escape)
					{
						goto Quit;
					}
					else
					{
						Console.WriteLine(" -- Wrong input. Try again! --");
						goto RepeatChoice;
					}
				}
				
			}
			while (InputMenuChoice.ToLower() != "end" || InputMenuChoice != "7.");
		Quit:
			Console.WriteLine("\n--------------------------------\n -- Exiting exercise... --");
			string Time1 = DateTime.Now.ToString("HH:mm:ss");
			Console.WriteLine("\t ==== Thank you for viewing my project! ====\t");
			Console.WriteLine("[-- Project -> Started in: {0} -- ]", Time);
			Console.WriteLine("[-- Project ---> Ended in: {0} -- ]", Time1);
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		static void PrintMenu()
		{
			Console.WriteLine(" ====== Welcome to the project! ======");
			Console.WriteLine(" ---- Menu: ----");
			Console.WriteLine(" -> I. Mirror a string in 2 ways. (Easiest; Using Stack);\n -> II. Pyramid Nx5 (Make it a pyramid, using Recursion);\n -> III. Geometry - Choose to type characteristics about one of 10 figures of your choice (Pure hell, 11 classes, Medium difficulty);\n -> IV. In The Darkest Castle v.3.0.β (Mini-game I, Medium - Hard difficulty);\n -> V. Validate audio file names and extensions (Harder; Using Excel 16 object library and REGEX);\n -> VI. Mario Minix (Hardest; Made in CTF 2.5, using more frames,behavior and events. Unfinished sadly.);\n[ -!- To choose one, write in format \"(Arabic number of exercise).\" when asked. -!- ]");
		}
		public static void PyramidNumx5(int n, int staticN, List<int> Pyramid)
		{
			if (Math.Abs(n) > staticN)
			{
				return;
			}
			Console.WriteLine(Math.Abs(n * 5));
			Pyramid.Add(Math.Abs(n * 5));
			PyramidNumx5(n - 1, staticN, Pyramid);
		}
		public static void ShowPyramid(int n, List<int> Pyramid)
		{
			int maxnum = n*5;
			int count = 0;
			int spaceremove = 1;
			// Keep going while the last digit is 0
			while (maxnum > 0 && maxnum % 10 == 0)
			{
				maxnum = maxnum / 10;
				count++;
			}
			Pyramid.Sort();
			int i, j, k = 0;
			int oldj = n;
			for (i = 1; i <= n + count; i++)
			{
				for (j = i; j <= oldj + count; j++)
				{
					Console.Write(" ");
				}
				while (k != (2 * i - 1))
				{
					if ((k == 0) || (k == 2 * i - 2))
					{
						Console.Write(Pyramid[0]);
						Pyramid.Remove(Pyramid[0]);
					}
					else
					{
						Console.Write("-");
					}
					k++;
				}
				k = 0;
				if (Pyramid.Count>0)
				{
					if (Pyramid[0]==10)
					{
						oldj=n-spaceremove;
					}
					if (Pyramid[0]==100)
					{
						oldj=n-2;
					}
				}
				Console.WriteLine();
			}
		}
	}
}