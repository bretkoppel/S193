//
//  PlayingCard.h
//  Matchismo
//
//  Created by Bret Koppel on 8/21/14.
//  Copyright (c) 2014 Bret Koppel. All rights reserved.
//

#import "Card.h"

@interface PlayingCard : Card
@property (strong, nonatomic) NSString *suit;

@property (nonatomic) NSUInteger rank;

+ (NSArray *)validSuits;
+ (NSUInteger)maxRank;
@end
