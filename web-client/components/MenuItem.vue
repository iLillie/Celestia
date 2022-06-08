<script setup lang="ts">
import {useNavigation} from "~/stores/navigation";

const route = useRoute();
const navigationStore = useNavigation();
const props = defineProps<{menuItem: any}>()

const isCollapsed = computed(() => navigationStore.isCollapsed);
const isActiveState = computed(() => route.path == props.menuItem.href);

</script>

<template>
  <li class="text-lg
              text-gray-600 hover:bg-neutral-50 hover:shadow-sm
              dark:hover:bg-neutral-700 dark:text-neutral-300 font-medium">
    <NuxtLink :class="isActiveState ? 'bg-neutral-50 shadow-sm dark:bg-neutral-700' : ''"
              :to="menuItem.href"
              class="flex items-center gap-2.5 p-4 rounded transition duration-300 ease-in-out">
      <span :style="`color: ${menuItem.color}`" :class="menuItem.icon"></span>
      <div v-if="!isCollapsed" class="">
        <p>{{ menuItem.text }}</p>
      </div>
    </NuxtLink>
  </li>
</template>

<style scoped>
  .hover-state {
    @apply bg-neutral-50 text-gray-600 shadow-sm;
  }

</style>
