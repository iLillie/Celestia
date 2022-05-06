<template>
    <ul class="list">
      <slot/>
    </ul>
</template>

<script>
export default {
  name: "MenuList"
}
</script>

<style scoped>
  .list {
    @apply grid gap-4;
  }
</style>
