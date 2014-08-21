//
//  CardGameViewController.m
//  Matchismo
//
//  Created by Bret Koppel on 8/21/14.
//  Copyright (c) 2014 Bret Koppel. All rights reserved.
//

#import "CardGameViewController.h"
#import "Deck.h"
#import "PlayingCardDeck.h"

@interface CardGameViewController ()

// the controller outlet is weak because the view already holds
// a strong reference to the label
@property (weak, nonatomic) IBOutlet UILabel *flipsLabel;

@property (nonatomic) int flipCount;

@property (nonatomic) Deck *deck;

@end

@implementation CardGameViewController

- (Deck *)deck {
    if (!_deck)
        _deck = [[PlayingCardDeck alloc] init];
    
    return _deck;
}

- (void)setFlipCount:(int)flipCount {
    _flipCount = flipCount;
    self.flipsLabel.text = [NSString stringWithFormat:@"Flips: %d", self.flipCount];
    NSLog(@"flipCount cdhanged to %d", self.flipCount);
}

// IBAction, IBOutlet -> void, just used for XCode sugar
- (IBAction)touchCardButton:(UIButton *)sender {
    // method call -> [, pointer to instance to call(or class name
    // if static), named args
    // the @ here makes a string, otherwise would be a const char*
    
    if ([sender.currentTitle length]){
        [sender setBackgroundImage:[UIImage imageNamed:@"cardback"]
                          forState:UIControlStateNormal];
        [sender setTitle:@"" forState:UIControlStateNormal];
    } else {
        Card *randomCard = [self.deck drawRandomCard];
        if (!randomCard) {
            UIAlertView *alert = [[UIAlertView alloc] initWithTitle:@"No cards left in the deck!" message:@"No cards left in the deck!" delegate:nil cancelButtonTitle:@"OK" otherButtonTitles:nil];
            [alert show];
            return;
        }
        [sender setBackgroundImage:[UIImage imageNamed:@"cardfront"]
                          forState:UIControlStateNormal];
        [sender setTitle:[randomCard contents] forState:UIControlStateNormal];
    }
    self.flipCount++;
}

@end
