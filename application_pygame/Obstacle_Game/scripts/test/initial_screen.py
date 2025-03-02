import pygame
import random

# Khởi tạo Pygame
pygame.init()

# Cấu hình màn hình
WIDTH, HEIGHT = 500, 600
screen = pygame.display.set_mode((WIDTH, HEIGHT))
pygame.display.set_caption("Dodge Game")

# Màu sắc
WHITE = (255, 255, 255)
BLUE = (0, 0, 255)
RED = (255, 0, 0)

# Tạo nhân vật
player_size = 50
player_x = WIDTH // 2 - player_size // 2
player_y = HEIGHT - player_size - 10
player_speed = 5

# Tạo vật thể rơi xuống
enemy_size = 50
enemy_x = random.randint(0, WIDTH - enemy_size)
enemy_y = -enemy_size
enemy_speed = 5

# Chạy game
running = True
clock = pygame.time.Clock()
while running:
    screen.fill(WHITE)

    for event in pygame.event.get():
        if event.type == pygame.QUIT:
            running = False

    # Điều khiển nhân vật
    keys = pygame.key.get_pressed()
    if keys[pygame.K_LEFT] and player_x > 0:
        player_x -= player_speed
    if keys[pygame.K_RIGHT] and player_x < WIDTH - player_size:
        player_x += player_speed

    # Cập nhật vị trí vật thể rơi
    enemy_y += enemy_speed
    if enemy_y > HEIGHT:
        enemy_y = -enemy_size
        enemy_x = random.randint(0, WIDTH - enemy_size)

    # Kiểm tra va chạm
    if (enemy_y + enemy_size > player_y and
        enemy_x < player_x + player_size and
        enemy_x + enemy_size > player_x):
        print("Game Over!")
        running = False

    # Vẽ nhân vật và vật thể
    pygame.draw.rect(screen, BLUE, (player_x, player_y, player_size, player_size))
    pygame.draw.rect(screen, RED, (enemy_x, enemy_y, enemy_size, enemy_size))

    pygame.display.update()
    clock.tick(30)

pygame.quit()
