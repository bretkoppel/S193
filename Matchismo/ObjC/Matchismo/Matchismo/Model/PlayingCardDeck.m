//
//  PlayingCardDeck.m
//  Matchismo
//
//  Created by Bret Koppel on 8/21/14.
//  Copyright (c) 2014 Bret Koppel. All rights reserved.
//

#import "PlayingCardDeck.h"
#import "PlayingCard.h"

@implementation PlayingCardDeck

// called immediately after alloc. should only be called
// with alloc.
- (instancetype)init{
    self = [super init];
    
    // if self fails to initialize, will be nil here
    if (self){
        for (NSString *suit in [PlayingCard validSuits]){
            for (NSUInteger rank = 1; rank <= [PlayingCard maxRank]; rank++){
                PlayingCard *card = [[PlayingCard alloc] init];
                card.rank = rank;
                card.suit = suit;
                [self addCard:card];
            }
        }
    }
    
    return self;
}
@end
